name "fibo-series"

org 100h

mov ax, 1
mov bx, 1


mov cx, 9

fibo: add ax, bx
      add bx, ax
loop fibo


ret