using System;

namespace LyricsSlide
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object
            var beatles = new SongLyrics();

            //Load lyrics
            //-------------------------

            //the beatles

            //let it be
            beatles.Lyrics(@"Let It Be 
The Beatles

When I find myself in times of trouble, Mother Mary comes to me
Speaking words of wisdom, let it be
And in my hour of darkness she is standing right in front of me
Speaking words of wisdom, let it be",
                @"Let It Be 
The Beatles

Let it be, let it be, let it be, let it be
Whisper words of wisdom, let it be",
                @"Let It Be 
The Beatles

And when the broken hearted people living in the world agree
There will be an answer, let it be
For though they may be parted, there is still a chance that they will see
There will be an answer, let it be",
                @"Let It Be 
The Beatles

Let it be, let it be, let it be, let it be
There will be an answer, let it be",
                @"Let It Be 
The Beatles

And when the night is cloudy there is still a light that shines on me
Shinin' until tomorrow, let it be
I wake up to the sound of music, Mother Mary comes to me
Speaking words of wisdom, let it be",
                @"Let It Be 
The Beatles

And let it be, let it be, let it be, let it be
Whisper words of wisdom, let it be");

            //love me do
            beatles.Lyrics(@"Love Me Do
The Beatles

Love, love me do
You know I love you
I'll always be true
So please, love me do
Whoa, love me do",
                @"Love Me Do
The Beatles

Love, love me do
You know I love you
I'll always be true
So please, love me do
Whoa, love me do",
                @"Love Me Do
The Beatles

Someone to love
Somebody new
Someone to love
Someone like you",
                @"Love Me Do
The Beatles

Love, love me do
You know I love you
I'll always be true
So please, love me do
Whoa, love me do",
                @"Love Me Do
The Beatles

Love, love me do
You know I love you
I'll always be true
So please, love me do
Whoa, love me do
Yeah, love me do
Whoa, oh, love me do");

            beatles.Lyrics(@"Twist And Shout
the beatles

Well, shake it up, baby, now (Shake it up, baby)
Twist and shout (Twist and shout)
C'mon c'mon, c'mon, c'mon, baby, now (Come on baby)
Come on and work it on out (Work it on out)",
                @"Twist And Shout
the beatles

Well, work it on out, honey (Work it on out)
You know you look so good (Look so good)
You know you got me goin' now (Got me goin')
Just like I knew you would (Like I knew you would)",
                @"Twist And Shout
the beatles

Well, shake it up, baby, now (Shake it up, baby)
Twist and shout (Twist and shout)
C'mon, c'mon, c'mon, c'mon, baby, now (Come on, baby)
Come on and work it on out (Work it on out)",
                @"Twist And Shout
the beatles

Well, you twist, you little girl (Twist, little girl)
You know you twist so fine (Twist so fine)
Come on and twist a little closer now (Twist a little closer)
And let me know that you're mine (Let me know you're mine)",
                @"Twist And Shout
the beatles

Well, shake it up, baby, now (Shake it up, baby)
Twist and shout (Twist and shout)
C'mon, c'mon, c'mon, c'mon, baby, now (Come on, baby)
Come on and work it on out (Work it on out)",
                @"Twist And Shout
the beatles

Well, you twist, you little girl (Twist, little girl)
You know you twist so fine (Twist so fine)
Come on and twist a little closer now (Twist a little closer)
And let me know that you're mine (Let me know you're mine)",
                @"Twist And Shout
the beatles

Well, shake it, shake it, shake it, baby, now (Shake it up baby)
Well, shake it, shake it, shake it, baby, now (Shake it up baby)
Well, shake it, shake it, shake it, baby, now (Shake it up baby)");

            //display lyrics
            //--------------

            beatles.DisplayLyrics();
        }
    }
}
