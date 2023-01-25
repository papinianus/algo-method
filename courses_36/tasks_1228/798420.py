# 税込価格を計算する関数
# price: int 型
# rate: int 型
# 返り値: int 型
def tax_included(price, rate):
    return price * (100 + rate) // 100

# 標準入力から受け取る
# X: int 型
X = int(input())

# 受け取った値を利用してコードを書いてください
print(tax_included(X, 10))