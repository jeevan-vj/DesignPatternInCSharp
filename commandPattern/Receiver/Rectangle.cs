namespace designPattern.Receiver {
    public class Rectangle {
        private int _height;
        private int _width;

        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }

        public void SetHeight (int height) {
            this.Height = height;
            System.Console.WriteLine($"Height is:{this.Height}");
        }

        public void SetWidth (int width) {
            this.Width = width;
            System.Console.WriteLine($"Width is:{this.Height}");
        }
    }
}