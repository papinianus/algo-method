# 標準入力から値を受け取る
# dist: int 型
dist = int(input())

# 受け取った値を利用してコードを書いてください
print(650 + dist * 300 + (-5000 if dist >= 100 else 0))