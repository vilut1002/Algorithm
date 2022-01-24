data = input()
group = 1
prev = (int)(data[0])

for i in range(1,len(data)):
    if (int)(data[i]) != prev:
        prev = (int)(data[i])
        group +=1
print(group//2)
