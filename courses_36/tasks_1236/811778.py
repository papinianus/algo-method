# 標準入力から値を受け取る
# num: int 型
num = int(input())

# 受け取った値を利用してコードを書いてください
if not(num % 2 == 0 or num % 3 ==0 or num % 5 == 0):
    print('Yes')
else:
    print('No')