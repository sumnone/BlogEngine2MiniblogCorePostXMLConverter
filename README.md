# BlogEngine2MiniblogCorePostXMLConverter
Converts BlogEngine.Net (dotnetblogengine.net) posts to Miniblog.Core (github.com/madskristensen/Miniblog.Core) posts.

BlogEngine.net and Miniblog.Core have a similar XML format for content. This program simply converts the older BlogEngine.net format to newer Miniblog.Core format.

There is a new version of BlogEngine.net at BlogEngine.io, but is not the original auther. This program should work for either version, although I didn't test with the newer version.

Both blogging platforms put posts in a folder called "posts." Simply copy the "posts" folder to your Windows desktop and run the converter. It will convert the output to the "posts/output" folder. It's easy enough to change the path if you want.

**NOTES:**

If your previous blog utilized the description element, you can change post.Title to post.Description for the new excerpt element. It wasn't required in BlogEngine.net and appears to be required in Miniblog.Core.

The comments and catagories sections are commented out and were never tested as they were not needed for the one time conversion. If used again in the future, those may be needed.