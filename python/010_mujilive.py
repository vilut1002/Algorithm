def solution(food_times, k):
    sorted_data = sorted(food_times)
    sum_, n = run(sorted_data, k)
    idx=-1
    k -= sum_
    j=0
    while k>0:
        if food_times[j%len(food_times)]>=n:
            idx = j
            k-=1
        j+=1
    return j%len(food_times)+1


def run(data, k):
    prev = 0
    summation = 0 
    for i in range(0,len(data)):
        if summation+(data[i]-prev)*(len(data)-i)>=k:
            return summation, data[i]
        else:
            if prev != data[i] or i==0:
                summation += (data[i]-prev)*(len(data)-i)
                prev = data[i]
    return 0, data[-1]
            