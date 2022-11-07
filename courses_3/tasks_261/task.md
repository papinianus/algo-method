## 問題文

長さ N の文字列 S が与えられます。
以下の条件をみたす整数の組 (x,y) の個数を数えるプログラムを作成してください。

- S の x 文字目と y 文字目は等しい
- 0≤x<y≤N−1

ただし、S の先頭の文字が 0 文字目であるとします。

## 入力

入力は次の形式で与えられます。

```text
N
S
```

また、入力される値は次の制約を満たします。

- N は 1 以上 100 以下の整数
- S は英小文字からなる長さ N の文字列

## 出力

答えを出力してください。

## 入出力例

### 入力例 1

```text
4
baab
```

### 出力例 1

```text
2
```

条件を満たす組は (x,y)=(0,3),(1,2) の 2 つです。