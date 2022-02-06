n = input()

left = 0
right = 0

for i in range (0,(int)(len(n)/2)):
    left += (int)(n[i])
for i in range ((int)(len(n)/2),(int)(len(n))):
    right += (int)(n[i])

if left == right:
    print("LUCKY")
else:
    print("READY")
