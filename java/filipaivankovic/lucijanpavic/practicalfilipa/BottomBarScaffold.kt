package filipaivankovic.lucijanpavic.practicalfilipa

import androidx.compose.foundation.Image
import androidx.compose.material.BottomNavigation
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.ui.Modifier
import androidx.navigation.NavController
import androidx.compose.material.Text
import androidx.compose.material.BottomNavigation
import androidx.compose.material.BottomNavigationItem
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.semantics.Role.Companion.Image
import androidx.navigation.compose.currentBackStackEntryAsState
import filipaivankovic.lucijanpavic.practicalfilipa.Navigation.NavItem

@Composable
fun BottomBar(modifier: Modifier = Modifier, navController: NavController) {

    val screens = listOf(
        NavItem.HomeScreen,
        NavItem.ListScreen,
        NavItem.FavoriteScreen,
        NavItem.MusicScreen,
    )

    BottomNavigation(
        modifier = Modifier
    ) {
        val navBackStatckEntry by navController.currentBackStackEntryAsState()
        val currentRoute = navBackStatckEntry?.destination?.route

        screens.forEach { screen ->
            BottomNavigationItem(
                icon = {
                    Image(
                        painter = painterResource(id = screen.icon),
                        contentDescription = "icon"
                    )
                },

                label = { Text(text = screen.route) },
                selected = currentRoute == screen.route,

                onClick = {
                    navController.navigate(screen.route){
                        launchSingleTop = true
                    }
                }

            )
        }
    }
}//Bottom Bar