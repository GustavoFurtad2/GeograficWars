function removeSpaces(string) {

    let newstring = ""
    let onString = false

    for (charIndex in string.length) {

        const currentChar = string.substring(charIndex, charIndex)

        if (currentChar == '"' || currentChar == "'") {

            onString = !onString
        }

        if (onString || !onString && currentChar != " ") {

            newstring += currentChar
        }
    }

    return newstring
}

module.exports = {
    removeSpaces
}
