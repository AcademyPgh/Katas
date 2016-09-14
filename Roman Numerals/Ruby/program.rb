require './converter'

convert = RomanConverter.new
convert.setup_denominations
puts "Enter a number to convert: "
number = gets.chomp.to_i
puts convert.convert(number)
