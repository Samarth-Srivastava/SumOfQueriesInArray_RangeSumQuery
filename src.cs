class Solution {
    public List<long> rangeSum(List<int> A, List<List<int>> B) {
        int N = A.Count();
        List<long> pfSum = new List<long>();
        long sum = 0;
        for(int i = 0; i < N; i++){
            sum =  sum + A[i];
            pfSum.Add(sum);
        }
        int M = B.Count();
        //Console.WriteLine(M);
        List<long> ans = new List<long>();
        long sum1 = 0;
        for(int i = 0; i < M; i++){
            sum1 = PrefixSum(pfSum, B[i][1] - 1) - PrefixSum(pfSum, B[i][0] - 2);
            ans.Add(sum1);
        }
        return ans;
    }

    public long PrefixSum(List<long> pfSum,int pos){
        if(pos < 0){
            return 0;
        }
        return pfSum[pos];
    }
}
