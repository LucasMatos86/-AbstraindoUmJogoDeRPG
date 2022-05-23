namespace DOTNET___POO.src.Entities
{
    public class Hero
    {
        public Hero(string name,int level,string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;

        }
        public string name;
        public int level;
        public string heroType;

        
        public override string ToString()
        {
            return "Name: " + this.name+"\nLevel: "+ this.level +"\nHeroType "+ this.heroType;
        }
        public virtual string Attack(){
            return this.name + " Atacou com sua espada";
        }
    }
}