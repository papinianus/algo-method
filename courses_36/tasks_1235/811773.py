# 標準入力から値を受け取る
# diff: int 型
diff = int(input())

# 受け取った値を利用してコードを書いてください
if diff % 10 == 0:
    print('special')
elif diff < 10:
    print('easy')
elif diff < 20:
    print('normal')
else:
    print('hard')