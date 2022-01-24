n = map(int, input())
data = list(map(int, input().split(" ")))

group = 0
data.sort()
i = 0
while i <len(data):
    if data[i]==1:
        group += 1
        i += 1
    else:
        if i+data[i]-1<len(data):
            if data[i]==data[data[i]+i-1]:
                group += 1
                i+=data[i]-1
    i += 1

print(group)


