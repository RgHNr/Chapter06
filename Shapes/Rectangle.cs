public class Rectangle :Shape{

    public Rectangle(float height=0, float width=0){

        Height = height;
        Width = width;

        
    }

    public override double Area {


        get { return Width*Height; }


        }
}