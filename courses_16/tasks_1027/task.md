## 問題文

ある路線には N 個の駅があります。 すべての駅は一直線に並んでおり、始点から順に 0 から N−1 までの番号が振られています。 また、駅 i から 駅 i+1 までの距離は di​ であることがわかっています (0≤i≤N−2)。

## 次の Q 個の質問に答えてください。

各質問では、22 つの駅 l, rl, r (l < rl < r) が指定されます。

## 駅 ll から駅 rr までの距離を求めてください。

## 入力

入力は次の形式で与えられます。ただし、li​,ri​ は i 回目の質問内容を表します。

```text
N
d0 d1 … dN−2
Q
l0 r0​
l1 r1
⋮⋮
lQ−1 rQ−1
```

また、入力される値は次の制約を満たします。

- N は 2 以上 105 以下の整数
- di​ は 1 以上 100 以下の整数 (0≤i≤N−2)
- Q は 1 以上 105 以下の整数
- li​,ri​ は 0 以上 N−1 以下の整数 (0≤i≤Q−1)
- li​ < ri​ (0≤i≤Q−1)

## 出力

答えを Q 行で出力してください。 i 行目には、 i 番目の質問の答えを出力してください。

## 入出力例

### 入力例 1

```text
3
3 5
2
0 2
1 2
```

### 出力例 1

```text
8
5
```

この入力では 3 つの質問が与えられます。 最初の質問の答えは駅 0 から駅 2 までの距離である 3+5=8 なので、最初の行には 8 を出力します。

### 入力例 2

```text
4
1 10 100
3
1 3
1 3
1 3
```

### 出力例 2

```text
110
110
110
```

同じ質問を複数回尋ねられることもあります。
