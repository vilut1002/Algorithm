n, m = map(int, input().split(" "))
data = list(map(int, input().split(" ")))

combi = n*(n-1)/2

data.sort()

count = 1
prev = data[0]

for i in range(1,len(data)):
    if data[i] == prev:
        count+=1
    else:
        combi -= count*(count-1)/2
        count = 1
        prev = data[i]
combi -= count*(count-1)/2
count = 1
prev = data[i]

print((int)(combi))