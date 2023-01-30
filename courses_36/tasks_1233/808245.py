# 標準入力から値を受け取る
# age: int 型
age = int(input())

# 受け取った値を利用してコードを書いてください
if age < 15: # もし、x の値が 10 未満なら
    print("child")
elif age < 65: # そうでなくてもし、x の値が 20 未満なら
    print("working-age")
else: # そうでないなら
    print("senior")