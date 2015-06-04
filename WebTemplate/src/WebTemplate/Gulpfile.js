/// <binding BeforeBuild='prod' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var del = require('del');

var config = {
    //Include all js files but exclude any min.js files
    src: ['wwwroot/lib/**/*.js', '!wwwroot/lib/**/*.min.js'],
    raw: ['./bower_components/angular/**/angular*.js',
        //'./bower_components/angular-sanitize/angular*.js',
        //'./bower_components/angular-route/angular*.js',
        './wwwroot/app/*.js',
        '!./bower_components/**/*.min.js']
}

gulp.task("clean", function () {
    del.sync("wwwroot/lib");
    del.sync("['wwwroot/lib-min/all.min.js]");
});

gulp.task('copy', function () {
    // place code for your default task here
    gulp.src("./bower_components/bootstrap/dist/**").pipe(gulp.dest("./wwwroot/lib/bootstrap"));
    gulp.src("./bower_components/angular/angular*.{js,map}").pipe(gulp.dest("./wwwroot/lib/angular"));
    gulp.src("./bower_components/angular-sanitize/angular*.js").pipe(gulp.dest("./wwwroot/lib/angular"));
});

gulp.task('minify', function () {
    gulp.src(config.raw)
    .pipe(uglify())
    .pipe(concat('all.min.js'))
    .pipe(gulp.dest('./wwwroot/lib-min'));
});

gulp.task('prod', ['clean','copy','minify'], function () {
    return true;
});