import { createInterface } from 'readline';

const main = (lines: string[]) => {
  console.log(Number(lines[0]) * 2);
};

// io in reference of https://algo-method.com/submissions/274363

const lines: string[] = [];

const readline = createInterface({
  input: process.stdin,

  output: process.stdout,
});

readline.on('line', (line) => lines.push(line));

readline.on('close', () => {
  main(lines);
});
