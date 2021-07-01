ORG 100h

MOV ax, 1
MOV bx, 1
MOV cx, 9

fibonacci:
ADD ax, bx
ADD bx, ax
LOOP fibonacci

RET