`if-else` 構文を用いると、 1 つの条件式による場合分けを行うことができました。

`and` 演算子や `or` 演算子を用いると、複数の条件式を組み合わせた場合分けを行うことができます。

### and 演算子

`and` 演算子を用いると、左右の条件式がともに正しいかを確かめることができます。

`A and B` は、`A` と `B` の値がともに `True` のときに限り `True` となります。

| A の値  | B の値  | A and B の値 |
| ------- | ------- | ------------ |
| `True`  | `True`  | `True`       |
| `True`  | `False` | `False`      |
| `False` | `True`  | `False`      |
| `False` | `False` | `False`      |

### or 演算子

`or` 演算子を用いると、左右の条件式の少なくともどちらかが正しいかを確かめることができます。

`A or B` は、`A` と `B` の少なくともどちらかが `True` (正しい) のときに `True` となります。

| A の値  | B の値  | A or B の値 |
| ------- | ------- | ----------- |
| `True`  | `True`  | `True`      |
| `True`  | `False` | `True`      |
| `False` | `True`  | `True`      |
| `False` | `False` | `False`     |

### 具体例

```python
print(3 < 5 and 1 <= 1) # True and True の値は True
print(3 < 5 and 3 <= 1) # True and False の値は True
print(3 < 5 or 3 <= 1)  # True or False の値は True
print(3 > 5 or 3 <= 1)  # False or False の値は False
```

## 問題文

3 つの整数 A,B,C が標準入力で与えられます。

B の値が A 以上かつ、B の値が C 未満ならば `Yes` と、そうでないならば `No` と出力するプログラムを作成してください。

### 入力形式について

入力は次の形式で与えてください。

```text
A
B
C
```

つまり、 A,B,C の値を 1 行ずつ、計 3 行からなる入力を与えてください。

ただし、A,B,C の値はそれぞれ 1 以上 10 以下とします。

## 入出力例

### 入力例 1

```text
4
7
9
```

### 出力例 1

```
Yes
```

この例では、A,B,C はそれぞれ 4,7,9 です。

B は 4 以上 9 未満の整数なので、`Yes` を出力します。

入力欄に入力例 1 を入力し実行すると、次のように表示されるプログラムを作りましょう。

![image](https://algo-method-public-production.s3.ap-northeast-1.amazonaws.com/images%2F227051ad-a060-4bb7-b925-2053390884ed%2F%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%BC%E3%83%B3%E3%82%B7%E3%83%A7%E3%83%83%E3%83%88+2023-01-30+18.52.18.png)

### 入力例 2

```text
10
10
10
```

### 出力例 2

```text
No
```
