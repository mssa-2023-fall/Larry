def binary_search(list, item):
    low = 0
    high = len(list)-1

    while low <= high:
        # Had to use integer division (//) instead of regular division (/)
        mid = (low + high) // 2
        guess = list[mid]
        if guess == item:
            return mid
        if guess > item:
            high = mid - 1
        else:
            low = mid + 1
    # This return statement should be outside the while loop (by outside Python means INDENTATION)
    return None


my_list = [1, 3, 5, 7, 9, 10, 11, 12, 14, 15]

print(binary_search(my_list, 7))
