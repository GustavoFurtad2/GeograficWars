function encode(string)

    local encodedString = ""
    local onString = false

    for charIndex = 1, string:len() do

        local currentChar = string:sub(charIndex, charIndex)

        if currentChar == '"' or currentChar == "'" then

            onString = not onString
        end

        if onString or not onString and currentChar ~= " " then

            encodedString = encodedString .. currentChar
        end
    end

    return encodedString
end
