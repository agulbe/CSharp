//using Android.Webkit;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.Collections.ObjectModel;
using System.Windows.Input;
using ToDoApp.Models;
using ToDoApp.Services;

namespace TodoApp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly DatabaseService _db;

    [ObservableProperty]
    private ObservableCollection<ToDoItem> _toDoItems = new();
    public ObservableCollection<ToDoItem> ToDoItems { get => _toDoItems; set => _toDoItems = value; }

    [ObservableProperty]
    private ObservableCollection<Category> _categories = new();
    public ObservableCollection<Category> Categories { get => _categories; set => _categories = value; }

    [ObservableProperty]
    private Category? _selectedCategory;
        public Category? SelectedCategory { get => _selectedCategory; set => _selectedCategory = value; }

    [ObservableProperty]
    private string? _newItemName = string.Empty;
    public string? NewItemName { get => _newItemName; set => _newItemName = value; }

    [ObservableProperty]
    private string? _newItemDetails = string.Empty;
    public string? NewItemDetails { get => _newItemDetails; set => _newItemDetails = value; }

    [ObservableProperty]
    private DateTime _newItemDueDate = DateTime.Now.AddDays(1);
    public DateTime NewItemDueDate { get => _newItemDueDate; set => _newItemDueDate = value; }

    [ObservableProperty]
    private int _selectedCategoryId;
    public int SelectedCategoryId { get => _selectedCategoryId; set => _selectedCategoryId = value; }
    public ICommand LoadItemsCommand { get; }
    public ICommand AddItemCommand { get; }
    public ICommand DeleteItemCommand { get; }
    public ICommand ToggleCompleteCommand { get; }
    public ICommand FilterByCategoryCommand { get; }
    public ICommand ShowOverdueCommand { get; }
    public ICommand ShowCompletedCommand { get; }
    public ICommand ShowAllCommand { get; }
    public ICommand AddCategoryCommand { get; }
    public ICommand DeleteCategoryCommand { get; }

    public MainViewModel(DatabaseService databaseService)
    {
        _db = databaseService;

        LoadItemsCommand = new AsyncRelayCommand(LoadItemsAsync);
        AddItemCommand = new AsyncRelayCommand(AddItemAsync);
        DeleteItemCommand = new AsyncRelayCommand<ToDoItem>(DeleteItemAsync);
        ToggleCompleteCommand = new AsyncRelayCommand<ToDoItem>(ToggleCompleteAsync);
        FilterByCategoryCommand = new AsyncRelayCommand(FilterByCategoryAsync);
        ShowOverdueCommand = new AsyncRelayCommand(ShowOverdueAsync);
        ShowCompletedCommand = new AsyncRelayCommand(ShowCompletedAsync);
        ShowAllCommand = new AsyncRelayCommand(LoadItemsAsync);
        AddCategoryCommand = new AsyncRelayCommand<string>(AddCategoryAsync);
        DeleteCategoryCommand = new AsyncRelayCommand<Category>(DeleteCategoryAsync);
    }

    private async Task LoadItemsAsync()
    {
        var items = await _db.GetToDoItemsAsync();
        ToDoItems = new ObservableCollection<ToDoItem>(items);

        var cats = await _db.GetCategoriesAsync();
        Categories = new ObservableCollection<Category>(cats);
    }

    private async Task AddItemAsync()
    {
        if (string.IsNullOrWhiteSpace(NewItemName)) return;

        var item = new ToDoItem
        {
            Name = NewItemName,
            Details = NewItemDetails,
            DueDate = NewItemDueDate,
            CategoryId = SelectedCategoryId,
            IsFinished = false
        };

        await _db.SaveToDoItemAsync(item);
        NewItemName = string.Empty;
        NewItemDetails = string.Empty;
        await LoadItemsAsync();
    }

    private async Task DeleteItemAsync(ToDoItem? item)
    {
        if (item == null) return;
        await _db.DeleteToDoItemAsync(item);
        await LoadItemsAsync();
    }

    private async Task ToggleCompleteAsync(ToDoItem? item)
    {
        if (item == null) return;
        item.IsFinished = !item.IsFinished;
        await _db.SaveToDoItemAsync(item);
        await LoadItemsAsync();
    }

    private async Task FilterByCategoryAsync()
    {
        if (SelectedCategory == null) return;
        var items = await _db.GetToDoItemsAsync(SelectedCategory.CategoryId);
        ToDoItems = new ObservableCollection<ToDoItem>(items);
    }

    private async Task ShowOverdueAsync()
    {
        var items = await _db.GetOverdueItemsAsync();
        ToDoItems = new ObservableCollection<ToDoItem>(items);
    }

    private async Task ShowCompletedAsync()
    {
        var items = await _db.GetCompletedItemsAsync();
        ToDoItems = new ObservableCollection<ToDoItem>(items);
    }

    private async Task AddCategoryAsync(string? categoryName)
    {
        if (string.IsNullOrWhiteSpace(categoryName)) return;

        var category = new Category { Name = categoryName, Details = string.Empty };
        await _db.SaveCategoryAsync(category);
        await LoadItemsAsync();
    }

    private async Task DeleteCategoryAsync(Category? category)
    {
        if (category == null) return;

        var items = await _db.GetToDoItemsAsync(category.CategoryId);
        foreach (var item in items)
            await _db.DeleteToDoItemAsync(item);

        await _db.DeleteCategoryAsync(category);
        await LoadItemsAsync();
    }
}