$(function() {
    $(".code").each(function(i, block) {
        hljs.fixMarkup(hljs.highlightBlock(block).value);
    });
});

