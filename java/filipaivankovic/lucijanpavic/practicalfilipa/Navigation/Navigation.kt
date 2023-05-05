package filipaivankovic.lucijanpavic.practicalfilipa.Navigation

import androidx.compose.runtime.Composable
import androidx.navigation.NavController
import androidx.navigation.NavHostController
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import filipaivankovic.lucijanpavic.practicalfilipa.Views.FavoriteScreen
import filipaivankovic.lucijanpavic.practicalfilipa.Views.HomeScreen
import filipaivankovic.lucijanpavic.practicalfilipa.Views.ListScreen
import filipaivankovic.lucijanpavic.practicalfilipa.Views.MusicScreen

@Composable
fun Navigation(navController: NavHostController){
    NavHost(navController = navController, startDestination = NavItem.HomeScreen.route){
        composable(NavItem.HomeScreen.route){
            HomeScreen(navController)
        }
        composable(NavItem.ListScreen.route){
            ListScreen(navController)
        }
        composable(NavItem.FavoriteScreen.route){
            FavoriteScreen(navController)
        }
        composable(NavItem.MusicScreen.route){
            MusicScreen(navController)
        }
    }
}