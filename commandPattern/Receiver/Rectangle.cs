namespace designPattern.Receiver {
    public class Rectangle {
        private int _height;
        private int _width;
        public void SetHeight (int height) {
            this._height = height;
            System.Console.WriteLine($"Height is:{this._height}");
        }

        public void SetWidth (int width) {
            this._width = width;
            System.Console.WriteLine($"Width is:{this._height}");
        }
    }
}