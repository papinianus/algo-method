関数は、中で使われる値を呼び出すときに指定する (渡す) ことが可能です。 その際、どのような値が渡されるかはあらかじめ指定しておく必要があります。

たとえば、`print()` という関数は「カッコの中に書かれた文字列を出力する」という処理を行うものですが、この「カッコの中に書かれた文字列」が「関数の中で使われる値」にあたります。

この「関数に渡すカッコの中の値」は**引数**と呼びます。

---

次のコードは、文字列を表示する `hello(name)` という関数を作成し呼び出すものです。

4,5,6 行目において渡される引数は変数 `name` に代入され関数内で利用されます。

```python
def hello(name):
    print(f"Hello!, {name}")

hello("aruru") # 出力: "Hello, aruru!"
hello("iruru") # 出力: "Hello, iruru!"
hello("ururu") # 出力: "Hello, ururu!"
```

このコードを関数を使わずに書くと次のようになります。

```python
name = "aruru"
print(f"Hello, {name}!") # 出力: "Hello, aruru!"
name = "iruru"
print(f"Hello, {name}!") # 出力: "Hello, iruru!"
name = "ururu"
print(f"Hello, {name}!") # 出力: "Hello, ururu!"
```

---

また、関数で渡す引数は `,` で区切ることで複数個渡すことができます。 たとえば次のコードは、2 つの引数を足し算した結果を表示する `addition(A, B)` という関数を作成し呼び出すものです。

(`addition` は日本語で「足し算」という意味です。)

```python
def addition(a, b):
    print(f"{a} + {b} = {a + b}")

addition(2, 3) # 出力: "2 + 3 = 5"
addition(17, 83) # 出力: "17 + 83 = 100"
```

## 問題文

次の (1) から (3) のコードの実行したとき、出力される値をそれぞれ答えてください。

### (1)

```python
def initial(name):
    print(name[0])

initial("aruru")
```

### (2)

```python
def f(x):
    y = 2 * x + 5
    print(y)

f(3)
```

### (3)

```python
def multiplication(A, B):
    print(A * B)

X = 6
multiplication(X, X)
```
