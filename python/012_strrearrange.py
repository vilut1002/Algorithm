data = input()

sorted_list = sorted(list(data))
sum = 0
idx = -1
s = ""
for i in range(0, len(sorted_list)):
    if (ord)(sorted_list[i])<ord("A"):
        sum += (int)(sorted_list[i])
        if idx<0:
            idx = i
    else:
        s+=sorted_list[i]

s += (str)(sum)
print(s)
