data=input()
result=(int)(data[0])
for i in range(1, len(data)):
    if (int)(data[i])<2 or result==0:
        result += (int)(data[i])
    else:
        result *= (int)(data[i])

print(result)