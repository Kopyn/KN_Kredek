import React, { useState, useEffect } from 'react';
import { Layout, Menu } from 'antd';
import { PieChartOutlined, PlusOutlined} from '@ant-design/icons';
import './App.css';
import GetAllPostsView from './GetAllPostsView';
import CreatePostView from './CreatePostView';

const { Content, Sider, Header} = Layout;

function App() {
	const [isViewOnGetAll, setIsViewOnGetAll] = useState(true);
  const [allData, setAllData] = useState([]);

	const handleChangeToGetAll = () => setIsViewOnGetAll(true);
	const handleChangeToCreate = () => setIsViewOnGetAll(false);

  // on component Load
	useEffect(() => {
		console.log('zostałem uruchomiony');

    fetch('https://jsonplaceholder.typicode.com/posts', { method: 'get' })
			.then((res) => res.json())
			.then((dataParsed) => {
				setAllData(dataParsed);
			});

		// on component umount
		return () => {
			console.log();
		};
	}, []);

  const addData = (values) => {
	  	console.log(values);
		const newData = [...allData];
		newData.push({
			userId: values.userId,
			id: values.id,
      		title: values.title,
      		body: values.body
		});
		setAllData(newData);  
	};

	const deleteData = (values) => {
			console.log("aa");
			console.log(values);
			console.log("ss");
			let newData = [...allData];
			newData = newData.filter((value) => value.id !== values.id)
			setAllData(newData); 
	  };

	  const updateData = (values) => {
		  console.log(values);
		let newData = [...allData];
		for (var i = 0; i < allData.length; i++) {
			console.log(allData[i]);
			if(allData[i].id == values.id){
				console.log("yas");
				console.log(values);
				allData[i] = values;
				newData[i] = values;
				break;
			}
		 }
		setAllData(newData); 
  };

	return (
		<Layout style={{ minHeight: '100vh' }}>
			<Sider>
				<div className='logo'>
					<h1 className='font-display m-1'>Posty</h1>
				</div>
				<Menu theme='light' mode='inline' defaultSelectedKeys={[1]} selectedKeys={isViewOnGetAll ? [1] : [2]}>
					<Menu.Item key='1' icon={<PieChartOutlined />} onClick={handleChangeToGetAll}>
						Posts Menu
					</Menu.Item>
					<Menu.Item key='2' icon={<PlusOutlined />} onClick={handleChangeToCreate}>
						Dodaj Post!
					</Menu.Item>
				</Menu>
			</Sider>
			<Layout>
				<Header>
					<h2>Posty!</h2>
				</Header>
				<Content>{isViewOnGetAll ? <GetAllPostsView data={allData} deletePost={deleteData} updatePost={updateData} /> : <CreatePostView data={allData} update={addData} />}</Content>
			</Layout>
		</Layout>
	);
}

export default App;
