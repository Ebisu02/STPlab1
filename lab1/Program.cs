namespace consoleApp
{
    public static class App
    {
        public static float getMultiOfNotEvenIndexesFromArray(float[] arr)
        {
            float result = arr[1];
            for (int i = 3; i < arr.Length; i += 2)
            {
                result *= arr[i];
            }
            return result;
        }
        public static void shiftArray(float[] arr, int h)
        {
            int len = arr.Length;
            if (len <= 1 || h == 0) { return; }
            h = h % len;
            if (h < 0) { h += len; }
            float[] t = new float[len];
            Array.Copy(arr, len - h, t, 0, h);
            Array.Copy(arr, 0, t, h, len - h);
            Array.Copy(t, arr, len);
        }
        public static int getValue(char c)
        {
            if (char.IsDigit(c)) { return (int)(c - '0'); }
            else { return (int)(char.ToUpper(c) - 'A' + 10); }
        }
        public static int fromBase(int b, string s)
        {
            int res = 0;
            double fraction = 1.0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int value = getValue(s[i]);
                if (value >= b)
                {
                    throw new Exception("Invalid input string for the given base!");
                }
                res += (int)(value * fraction);
                fraction *= b;
            }
            return res;
        }
        public static void Main()
        {
            float[] arr = { 1f, 2.2f, 3f, 4f, 5f };
            Console.WriteLine(getMultiOfNotEvenIndexesFromArray(arr));
            shiftArray(arr, 2);
            foreach (float f in arr) { Console.Write("[" + f + "] "); } Console.WriteLine();
            Console.WriteLine(fromBase(2, "10100"));
        }
    } 
}