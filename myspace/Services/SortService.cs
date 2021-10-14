namespace myspace.Services
{
    public class SortService
    {

        public void TheSimplestSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        var tempValue = A[i];
                        A[i] = A[j];
                        A[j] = tempValue;
                    }
                }
            }
        }

        public void TheSimplestSortReverse(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] > A[j])
                    {
                        var tempValue = A[j];
                        A[j] = A[i];
                        A[i] = tempValue;
                    }
                }
            }
        }

        public void FastSort(int[] A)
        {
            System.Array.Sort(A);
        }
        public void FastSortReverse(int[] A)
        {
            System.Array.Sort(A);
            System.Array.Reverse(A);
        }
    }
}
