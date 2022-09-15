using System;

namespace project1 {
    class Program {
        static void Main( string[ ] args ) {
            string[ ] project1 =
            {
                "--------------------",
                "|              |",
                "|             ( )",
                "|              |",
                "|            --|--",
                "|              ^",
                "|             | |",
                "|             | |",
                "|             ",
                "|-------------------",
            };
            //出題者の入力フェーズ
            Console.WriteLine( "英単語を入力してください" );
            string word = Console.ReadLine( );

            //画面クリア
            Console.Clear( );

            //下線を表示
            for( int i = 0; i < word.Length; i++ ) {
                Console.Write( "_ " );
            }

            char[ ] answer = new char[ word.Length ];
            for( int i = 0; i < answer.Length; i++ ) {
                answer[ i ] = '_';
            }

            //間違えようカウンター
            int count = 0;

            bool loop_Check = true;
            while( loop_Check ) {
                //回答者の入力フェーズ
                Console.WriteLine( );
                Console.WriteLine( );
                Console.WriteLine( "アルファベット1文字を入力してください。" );
                string alphabet = Console.ReadLine( );

                if( alphabet.Length != 1 ) {
                    Console.Clear( );
                    continue;
                }

                //画面クリア
                Console.Clear( );

                bool check = false;
                for( int i = 0; i < word.Length; i++ ) {
                    //正解の時の処理
                    if( word[ i ] == char.Parse( alphabet ) ) {
                        answer[ i ] = char.Parse( alphabet );
                        check = true;
                    }
                }
                if( !check ) {
                    count++;
                }
                string tmp = new string( answer );
                foreach( char value in tmp ) {
                    Console.Write( value + " " );
                }

                //不正解の場合紋首台の描画
                Console.WriteLine( );
                Console.WriteLine( );
                for( int i = 0; i < count; i++ ) {
                    Console.WriteLine( project1[ i ] );
                }

                //勝ち判定
                if( !tmp.Contains( "_" ) ) {
                    Console.WriteLine( "勝ちです。" );
                    loop_Check = false;
                }
                //負け判定
                else if( count == project1.Length ) {
                    Console.WriteLine( "負けです。" );
                    loop_Check = false;
                }
            }
        }
    }
}
