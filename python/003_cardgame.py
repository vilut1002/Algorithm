n, m = map(int, input().split(" "))

data = []
for i in range (0, n):
    data.append(list(map(int, input().split(" "))))

least = []

# 가장 작은 값의 인덱스 찾는 함수
def find_min(list):
    min_idx = 0
    for i in range (1, len(list)):
        if list[i]<list[min_idx]:
            min_idx = i
    return list[min_idx]

for i in range(0, n):
    least.append(find_min(data[i]))

least.sort(reverse=True)
print(least[0])
