namespace Ders09_2e
{
    public class Dosya
    {
        public delegate void BildirEventHandler(object sender, BildirEventArgs e);
        public event BildirEventHandler OzellikDegisti;

        public bool IsReadOnly { get; 
            set
            {
                if(IsReadOnly != value)
                {
                    if (OzellikDegisti != null)
                        OzellikDegisti(this,
                            new BildirEventArgs(
                                "IsReadOnly",
                                IsReadOnly,
                                value
                                )
                            );
                }
                IsReadOnly = value;
            }
        }
        public DateTime LastWriteTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public DateTime CreationTime { get; set; }
        public long Length { get; set; }
        public string DirectoryName { get; set; }
        public string Extension { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

    }
}
