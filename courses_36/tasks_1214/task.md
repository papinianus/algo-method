実は、変数の値は再度の代入によって上書きすることができます。

---

まずは次のコードを考えてみましょう。

```python
price = 8000
price = 6000
print(price) # 出力: 6000
```

このコードは、1 行目で変数 `price` に 8000 を代入しています。

2 行目では変数 `price` に新たに 6000 が代入され、値が上書きされます。

したがって、この時点で変数 `price` の示す値は 6000 となります。

---

それでは、次のコードを実行するとどうなるでしょうか。

```python
price = 3000
price = price - 500
print(x) # 出力: 2500
```

このコードは、1 行目で変数 `price` に値 3000 を代入しています。

2 行目では変数 `price` に新たに

(現時点で `price` の示す値) −500=3000−500=2500 が代入され、値が上書きされます。

したがって、この時点で変数 `price` の示す値は 6000 となります。

## 問題文

次の (1) から (3) の Python のコードを実行したときに出力される値をそれぞれ答えてください。

### (1)

```python
deposit = 1200 # 貯金額
amount = 100 # 預金額
deposit = deposit + amount
print(deposit)
```

### (2)

```python
address = "aruru" # メールアドレスのアカウント名
domain = "algo-method.com" # ドメイン名
address = f"{address}@{domain}"
print(address)
```

### (3)

```python
num_1 = 5
num_2 = 3
num_1 = num_1 - num_2
num_2 = num_2 + num_1
num_1 = num_1 \* num_2
print(num_1)
```
