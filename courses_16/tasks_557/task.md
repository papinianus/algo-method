## 問題文

次のコードは、0 以上 N 未満の偶数の総和を求めるものです。 なお Python3 で記述していますが、他の言語でも同様です。

このコードに N=106 という入力を与えたとき、 アルゴ式サーバーでの計算時間は約 180 ms でした。

では、同じコードに N=107 という入力を与えたときの計算時間はどうなるでしょうか。 最も近いと思われるものを次の選択肢から選んでください。

```python3
# N の入力
N = int(input())

# 偶数の総和を求める
res = 0
i = 0
while i < N:
    res += i

    # i を 2 進める
    i += 2
print(res)
```

---

1. 180 ms
2. 1800 ms
3. 18000 ms
4. 180000 ms
5. 1800000 ms

---
