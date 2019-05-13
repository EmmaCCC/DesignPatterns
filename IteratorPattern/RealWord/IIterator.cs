namespace IteratorPattern.RealWord
{
    /// <summary>
    /// 迭代器接口（要实现迭代的过程需要的操作，当然也可以加其他方法，具体要看迭代需求，下边是最基本的三个方法
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// 是否能向下一个移动，如果你能，就移动，如果不能就停止，循环迭代的时候是靠这个方法
        /// 判断是否继续还是停止循环的
        /// </summary>
        /// <returns></returns>
        bool MoveNext();
        /// <summary>
        /// 既然要迭代，肯定要能获取到当前元素
        /// </summary>
        /// <returns></returns>
        object GetCurrent();

        /// <summary>
        /// 复位，从0开始，一般使用不到，但是如果你迭代完，想再次迭代，或者要保证迭代重新开始的话，要复位一下
        /// </summary>
        void Reset();

    }
}