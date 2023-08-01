namespace TDD_WORKSHOP
{
    public class ClosedRange
    {
        public ClosedRange(int lowerPoint, int upperPoint)
        {
            if (upperPoint < lowerPoint) { throw new ArgumentException(); }

            UpperPoint = upperPoint;
            LowerPoint = lowerPoint;
        }

        /// <summary>
        /// 下端点
        /// </summary>
        public int LowerPoint { set; get; }

        /// <summary>
        /// 上端点
        /// </summary>
        public int UpperPoint { get; set; }

        /// <summary>
        /// 閉区間を文字列で返す
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"[{LowerPoint},{UpperPoint}]";
        }

        /// <summary>
        /// 整数が閉区間内か判定する
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public bool IsInsided(int num)
        {
            return !(num < LowerPoint || UpperPoint < num);
        }
    }
}
