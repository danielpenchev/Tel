function solve(args) {
  var width = Number(+args[0]);
  var height = Number(+args[1]);

  var area = width * height;
  var per = 2 * width + 2 * height;

  console.log(area.toFixed(2) + ' ' + per.toFixed(2));
}
