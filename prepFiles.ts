#!/usr/bin/env -S deno run --allow-all --unstable
import { parse } from 'https://deno.land/std@0.172.0/flags/mod.ts';
import { sep, join } from 'https://deno.land/std@0.172.0/path/mod.ts';
// -c course -t task -e codeFileExt -n codeFileName
const courseDirPrefix = `courses_`;
const taskDirPrefix = `tasks_`;
const taskFile = `task.md`;
const codeFileName = `a`;
const codeFileExt = `txt`;

const cwd = Deno.cwd();
const taskInfo = cwd
  .split(sep)
  .reduce(
    (a, c) =>
      c.startsWith(courseDirPrefix)
        ? { ...a, ['c']: Number(c.split('_')[1]) }
        : c.startsWith(taskDirPrefix)
        ? { ...a, ['t']: Number(c.split('_')[1]) }
        : a,
    { c: -1, t: -1 },
  );
const targetBaseDir = `${join(
  ...[cwd].concat(
    Array.from(
      { length: taskInfo.c === -1 ? 0 : taskInfo.t === -1 ? 1 : 2 },
      (_) => '..',
    ),
  ),
)}`;
const parsedArgs = parse(Deno.args);
taskInfo.t = parsedArgs.t ?? taskInfo.t;
if (taskInfo.t === -1) {
  console.warn('-t needed. task number must be set by option -t');
  Deno.exit(-1);
}
taskInfo.c = parsedArgs.c ?? taskInfo.c;
if (taskInfo.c === -1) {
  console.warn('-c needed. course number must be set by option -c');
  Deno.exit(-1);
}
const codeInfo = { name: codeFileName, ext: codeFileExt };
codeInfo.name = parsedArgs.n ?? codeInfo.name;
codeInfo.ext = parsedArgs.e ?? codeInfo.ext;
const targetDir = `${join(
  targetBaseDir,
  `${courseDirPrefix}${taskInfo.c}`,
  `${taskDirPrefix}${taskInfo.t}`,
)}`;
await Deno.mkdir(targetDir, { recursive: true });
await Deno.writeTextFile(join(targetDir, taskFile), '', { append: true });
await Deno.writeTextFile(
  join(targetDir, `${codeInfo.name}.${codeInfo.ext}`),
  '',
  { append: true },
);
