public class Circle :Shape{

    public Circle(float rad = 1){

        Height = rad*2;
        Width = rad*2;
        
    }

    public override double Area => Math.PI*Width*Width/4;
}