namespace Ders08_2d.Model
{
    public class Insan : IBuyume
    {
        private string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        private int boy;
        public int Boy{
            get
            {
                return boy;
            }
        }

        public void Buyu(int uzamaMiktari)
        {
            if (uzamaMiktari < 0)
                return;
            boy += uzamaMiktari;
        }

        public override string ToString()
        {
            return "Merhaba, ben " + ad + ", boyumda " + boy + "cm.";
        }
    }
}
