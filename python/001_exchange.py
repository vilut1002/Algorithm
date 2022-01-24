exchange = (int)(input("거스름돈을 입력하세요 : "))
count = 0

coin_types = [500, 100, 50, 10]

for coin in coin_types:
    count += exchange//coin
    exchange = exchange%coin

print(count)