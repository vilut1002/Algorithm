

public class Solution : VersionControl {

    
    public int FirstBadVersion(int n) {
        int min =0, max=n, mid = min+(max-min)/2;
        while(min!=mid){//여기 다시보기
            if(IsBadVersion(mid)){
                //true면 더 앞에서 감염
                max = mid;
                mid = min+(max-min)/2; 
            }
            else{
                //false면 더 뒤에서 감염
                min = mid;
                mid = min+(max-min)/2;
            }
        }
        return max;
    }
           
}