#!/usr/bin/env bash
basedir="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null 2>&1 && pwd )"
git submodule add git://github.com/dotdevelop/libgit-binary.git  main/external/libgit-binary
git submodule add git://github.com/dotdevelop/libgit2.git  main/external/libgit2
git submodule add git://github.com/dotdevelop/libgit2sharp.git  main/external/libgit2sharp
git submodule update --init --recursive
cd main/external/libgit-binary
git checkout  vs-8.0-v0.26.8
cd $basedir
cd main/external/libgit2
git checkout  vs-8.0-v0.26.8
cd $basedir
cd main/external/libgit2sharp
git checkout  dotdevelop







