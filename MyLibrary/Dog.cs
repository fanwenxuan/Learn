using System;
namespace MyLibrary
{
    public class Dog
    {
        //event
        public event EventHandler Shout;

        //field
        public int AngerLevel;

        public string Name;

        public Dog()
        {
            Name="Floppy";
        }

        //method
        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel>=3)
            {
                //is something is listening
                if(Shout!=null)
                {
                    //then raise the event
                    Shout(this,EventArgs.Empty);
                }
            }
        }

    
    }
}