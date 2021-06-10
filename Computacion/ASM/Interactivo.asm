INCLUDE 'emu8086.inc'
ORG 100h

; VARIABLES.---------------------------
cociente DB ?
resto DB ?

; PROGRAMA.----------------------------
LEA SI, numero1       ; pedir 1er nro
CALL print_string
CALL scan_num      ; get number in CX
MOV DX, CX         ; copy the number to AX
CALL pthis
DB 13, 10, 0

LEA SI, numero2       ; pedir 2do nro
CALL print_string
CALL scan_num
MOV BX, CX
CALL pthis
DB 13, 10, 0

PRINT '1(+), 2(-), 3(*), 4(/): '
CALL scan_num
MOV AX, 2
CMP AX, CX

je l2
jl l3
jg l1
  
l1: ADD DX, BX
    CALL pthis
    DB 13, 10, '[sumando...] > Resultado: ', 0
    MOV AX, DX
    CALL print_num
    RET

l2: SUB DX, BX
    CALL pthis
    DB 13, 10, '[restando...] > Resultado: ', 0
    MOV AX, DX
    CALL print_num
    RET

l3: MOV AX, 3
    CMP AX, CX
    jne l6
    MOV AX, DX
    MUL BX
    CALL pthis
    DB 13, 10, '[multiplicando...] > Resultado: ', 0
    CALL print_num
    RET

l6: MOV AX, DX
    MOV BL, 5
    DIV BL
    MOV cociente, AL
    MOV resto, AH
    MOV DL, cociente
    ADD DL, 48
    MOV AH, 2
    call pthis
    DB 10, 13, 0
    print "[dividiendo...] > Resultado: "
    INT 21h
    MOV DL, resto
    ADD DL, 48
    MOV AH, 2
    print ", (resto): "
    INT 21h
    RET

numero1 DB 'Ingrese el 1er nro: ', 0
numero2 DB 'Ingrese el 2do nro: ', 0          

DEFINE_SCAN_NUM
DEFINE_PRINT_STRING
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS    ;required for print_num
DEFINE_PTHIS

END