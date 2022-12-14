## 問題文

次のコードは、整数 N が素数かどうかを判定しています。 Python3 で記述していますが、他の言語でも同様です。

i=2,3,… に対して N が i が割り切れるかどうかを判定していき、 割り切れるものがあったら「素数ではない」ということになります。 なお、i×i≤N であるような i についてのみ調べれば十分であることが知られています。

このコードに N=1012 という入力を与えたとき、 アルゴ式サーバーでの計算時間は約 500 ms でした。

```text
# N の入力
N = int(input())

# 素数かどうか
is_prime = True

# i = 2, 3, ... を試し割りしていく
i = 2
while i * i <= N:
    if N % i == 0:
        is_prime = False
    i += 1
```

では、同じコードに N=1013 という入力を与えたときの計算時間はどうなるでしょうか。 最も近いと思われるものを次の選択肢から選んでください。

---

1. 500 ms
2. 1800 ms
3. 5000 ms
4. 18000 ms
5. 50000 ms

---
