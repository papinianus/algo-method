関数の内部で行った処理結果は、`return` という記法を用いて呼び出し元に返すことができます。

次のコードは、`number` の値を 3 倍し返す `triple(number)` という関数を作成し実行するものです。

たとえば、`triple(1)` によって呼び出された関数が返す値 (**返り値**) は 3 です。

```python
def triple(num):
    return num * 3

print(triple(1)) # 出力: 3
print(triple(2)) # 出力: 6
print(triple(3)) # 出力: 9
```

このコードを関数を使わずに書くと次のようになります。

```python
num = 1
print(num * 3) # 出力: 3
num = 2
print(num * 3) # 出力: 6
num = 3
print(num * 3) # 出力: 9
```

---

なお、次のように `return` により値を返さないコードを書いた場合、 `None` が出力されてしまいます。

```python
def triple(num):
    num * 3

print(triple(1)) # 出力: None
print(triple(2)) # 出力: None
print(triple(3)) # 出力: None
```

### None について

`None` は「値がないこと」を表す NoneType 型の値です。

今回のような `print()` 関数を実行した際に何も表示されないと、そもそも本当にプログラムが動いているのかがわからなかくなってしまいます。 こういった問題を解決するために、「値がないというその事実」を `None` という値によって表現します。

`None` は他の言語では `null` や `nil` と表されることもあります。

## 問題文

次の (1) から (3) のコードの実行したとき、出力される値をそれぞれ答えてください。

### (1)

```python
def half(num):
    return num // 2

print(half(30))
```

### (2)

```python
def add(A, B):
    return A + B

A = 20
B = 30
C = add(A, B)
print(C)
```

### (3)

```python
def triple(num):
    return num * 3

print(triple(triple(10)))
```
