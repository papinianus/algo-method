## 問題文

次のコードは、0 以上 N 未満の整数の総和を求めるものです。 なお Python3 で記述していますが、他の言語でも同様です。

このコードに N=106 という入力を与えたとき、 アルゴ式サーバーでの計算時間は約 260 ms でした。

```python3
# N の入力
N = int(input())

# 総和を表す変数
res = 0

# range(0, N) は 0 以上 N 未満の範囲を表す
# つまり変数 i は、i = 0, 1, ..., N - 1 を動く
for i in range(0, N):
    res += i
print(res)
```

では、同じコードに N=107 という入力を与えたときの計算時間はどうなるでしょうか。 最も近いと思われるものを次の選択肢から選んでください。

---

1. 260 ms
2. 2600 ms
3. 26000 ms
4. 260000 ms
5. 2600000 ms

---