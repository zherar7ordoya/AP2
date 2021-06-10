include 'emu8086.inc'

ORG 100h

.data
    q db ?
    r db ?
 .code
 
 
 LEA SI, msg1       ; ask for the number
 CALL print_string
 CALL scan_num      ; get number in CX
 
 MOV DX, CX         ; copy the number to AX
 
 
 CALL pthis
 DB 13, 10, 0
 
 
 LEA SI, msg2       ; ask for the number
 CALL print_string
 CALL scan_num
 
 MOV BX, CX
 
 
 CALL pthis
 DB 13, 10, 0
 
 
 print 'Press 1-ADD 2-SUB 3-MUL 4-DIV: '
 call scan_num
 
 
 mov ax, 2
 
 cmp ax, cx
 
 je l2
 jl l3
 jg l1
  
  
 l1: add DX, BX
     CALL pthis
     DB 13, 10, 'Sum of two number is: ', 0
     mov ax, dx
     CALL print_num
     ret
 
 
  l2: sub DX, BX
     CALL pthis
     DB 13, 10, 'Sub of two number is: ', 0
     mov ax, dx
     CALL print_num
     ret


 l3: mov ax, 3
     cmp ax, cx
     jne l6
     mov ax, dx
     mul BX
     CALL pthis
     DB 13, 10, 'Mul of two number is: ', 0
     CALL print_num
     ret            
     
 
 l6: mov ax, dx
     mov bl, 5
     div bl
     mov q, al
     mov r, ah
     
     
     mov dl, q
     add dl, 48
     mov ah, 2
     
     
     call pthis
     db 10, 13, 0
     print "Divisor is: "
     int 21h
     
     
     mov dl, r
     add dl, 48
     mov ah, 2
     
     
     
     print " Reminder is: "
     int 21h
     
     
     
RET

msg1 DB 'Enter the first number: ', 0
msg2 DB 'Enter the second number: ', 0          



DEFINE_SCAN_NUM
DEFINE_PRINT_STRING
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS    ;required for print_num
DEFINE_PTHIS


END     
     
