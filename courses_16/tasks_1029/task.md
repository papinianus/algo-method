## 問題文

あなたの手元には N 本のひもがあり、それぞれの長さは L0​,L1​,…,LN−1​ です。

あなたは欲しい長さのひもをすぐに取り出せるように、ひもを長さで検索できるプログラムを作成することにしました。
次の Q 個の質問に答えるプログラムを作成してください。

各質問では、見つけたいひもの長さの下限と上限を表す整数 A, BA, B (A ≤ BA ≤ B) が指定されます。

「長さが AA 以上 BB 以下であるようなひもの本数」を答えてください。

## 入力

入力は次の形式で与えられます。

```text
N
L0 L1 … LN−1
Q
A0 B0
A1 B1
⋮⋮
AQ−1 BQ−1
```

また、入力される値は次の制約を満たします。

- N は 1 以上 105 以下の整数
- Li​ は 1 以上 105 以下の整数 (0≤i≤N−1)
- Q は 1 以上 105 以下の整数
- Ai​,Bi​ は 1 以上 105 以下の整数 (0≤i≤Q−1)
- Ai​≤Bi​ (0≤i≤Q−1)

## 出力

答えを出力してください。

## 入出力例

### 入力例 1

```text
5
10 40 25 50 20
2
10 30
30 40
```

### 出力例 1

```text
3
1
```

この入力では 2 つの質問が与えられます。 最初の質問には長さが 10 以上 20 以下のひもの本数を答えればよいので、最初の行には 3 を出力します。

### 入力例 2

```text
10
10 10 10 10 10 10 10 10 10 10
3
1 20
1 20
100 120
```

出力例 2

```text
10
10
0
```

同じ質問を複数回尋ねられることもあります。
