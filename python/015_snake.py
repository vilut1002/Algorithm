from queue import Queue


n = int(input())
k = int(input())
time=0
board = [[0 for col in range(n)] for row in range(n)]
row, column = 0, 0
board[row][column] = 1
head = 0
tail = Queue()
tail.put((row, column))
for i in range (0, k):
    p, q = input().split(" ")
    board[int(p)][int(q)] = -1

l = int(input())

rotate ={}

for i in range(0, l):
    t, direction = input().split(" ")
    rotate[int(t)] = direction

while(True):
    #방향 돌려주기
    if time in rotate:
        if rotate[time] == "L":
            head += 90
        elif rotate[time] == "D":
            head -= 90
    head = head%360
    time+=1
    #전진할 위치 찾기, 시초선 0 동경기준
    if head == 0: # x축 양의방향
        column +=1
    elif head == 90:# y축 양의방향
        row -=1
    elif head == 180:# x축 음의방향
        column -= 1
    elif head == 270:# y축 음의방향
        row += 1
    tail.put((row, column))
    if row>=n or row<0 or column>=n or column<0:
        break #finish
    #사과 먹기
    if board[row][column] <0:
        board[row][column] = 1
    elif board[row][column] >0:
        break
    else:
        p, q = tail.get()
        board[p][q] = 0


print( time)
