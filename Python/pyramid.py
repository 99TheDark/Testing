def pyramid(input):
    idx = 0
    k = 1
    s = ''
    while idx < len(input):
        s += input[idx:(idx+k)] + '\n'
        idx += k
        k += 1
    s = s[:(len(s)-1)]
    print(s + '*' * (idx - len(input)))

pyramid('abcdefg')