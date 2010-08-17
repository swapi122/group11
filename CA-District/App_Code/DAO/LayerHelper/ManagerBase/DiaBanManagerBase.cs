




/*
'===============================================================================
'  LayerHelper.CAQ.BL.DiaBanManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class DiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DiaBanManagerBase()
		{
			// Nothing for now.
		}
		
		public DiaBanEntity Insert(DiaBanEntity _DiaBanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DiaBanEntity, true);
			}
			return _DiaBanEntity;
		}

		
		public DiaBanEntity Insert(Guid Id, string TenDiaBan, string MaRutGon, string SoHoSo, string DiaBanBaoVe, string MucTieuPhanGian, Guid IdHuyen, Guid IdXa, Guid IdThon, string Duong, string SoNha, Guid IdOkhuVuc, Guid IdToDanPho, string CoQuanChuQuanCapTren, string DienThoai, string NguoiDungDauMucTieu, string DtddnguoiDungDauMucTieu, string DtbanNguoiDungDauMucTieu, string NguoiDungDauBaoVe, string DtddnguoiDungDauBaoVe, string DtbanNguoiDungDauBaoVe, string Antt, string CongTacTrienKhai, string GhiChu, string TongSoNhanSu, string DanhSachNhanSu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			DiaBanEntity _DiaBanEntity = new DiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DiaBanEntity.Id = Id;
				_DiaBanEntity.TenDiaBan = TenDiaBan;
				_DiaBanEntity.MaRutGon = MaRutGon;
				_DiaBanEntity.SoHoSo = SoHoSo;
				_DiaBanEntity.DiaBanBaoVe = DiaBanBaoVe;
				_DiaBanEntity.MucTieuPhanGian = MucTieuPhanGian;
				_DiaBanEntity.IdHuyen = IdHuyen;
				_DiaBanEntity.IdXa = IdXa;
				_DiaBanEntity.IdThon = IdThon;
				_DiaBanEntity.Duong = Duong;
				_DiaBanEntity.SoNha = SoNha;
				_DiaBanEntity.IdOkhuVuc = IdOkhuVuc;
				_DiaBanEntity.IdToDanPho = IdToDanPho;
				_DiaBanEntity.CoQuanChuQuanCapTren = CoQuanChuQuanCapTren;
				_DiaBanEntity.DienThoai = DienThoai;
				_DiaBanEntity.NguoiDungDauMucTieu = NguoiDungDauMucTieu;
				_DiaBanEntity.DtddnguoiDungDauMucTieu = DtddnguoiDungDauMucTieu;
				_DiaBanEntity.DtbanNguoiDungDauMucTieu = DtbanNguoiDungDauMucTieu;
				_DiaBanEntity.NguoiDungDauBaoVe = NguoiDungDauBaoVe;
				_DiaBanEntity.DtddnguoiDungDauBaoVe = DtddnguoiDungDauBaoVe;
				_DiaBanEntity.DtbanNguoiDungDauBaoVe = DtbanNguoiDungDauBaoVe;
				_DiaBanEntity.Antt = Antt;
				_DiaBanEntity.CongTacTrienKhai = CongTacTrienKhai;
				_DiaBanEntity.GhiChu = GhiChu;
				_DiaBanEntity.TongSoNhanSu = TongSoNhanSu;
				_DiaBanEntity.DanhSachNhanSu = DanhSachNhanSu;
				_DiaBanEntity.IdNguoiTao = IdNguoiTao;
				_DiaBanEntity.NgayTao = NgayTao;
				_DiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DiaBanEntity.NgayCapNhat = NgayCapNhat;
				_DiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DiaBanEntity, true);
			}
			return _DiaBanEntity;
		}

		public DiaBanEntity Insert(string TenDiaBan, string MaRutGon, string SoHoSo, string DiaBanBaoVe, string MucTieuPhanGian, Guid IdHuyen, Guid IdXa, Guid IdThon, string Duong, string SoNha, Guid IdOkhuVuc, Guid IdToDanPho, string CoQuanChuQuanCapTren, string DienThoai, string NguoiDungDauMucTieu, string DtddnguoiDungDauMucTieu, string DtbanNguoiDungDauMucTieu, string NguoiDungDauBaoVe, string DtddnguoiDungDauBaoVe, string DtbanNguoiDungDauBaoVe, string Antt, string CongTacTrienKhai, string GhiChu, string TongSoNhanSu, string DanhSachNhanSu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			DiaBanEntity _DiaBanEntity = new DiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DiaBanEntity.TenDiaBan = TenDiaBan;
				_DiaBanEntity.MaRutGon = MaRutGon;
				_DiaBanEntity.SoHoSo = SoHoSo;
				_DiaBanEntity.DiaBanBaoVe = DiaBanBaoVe;
				_DiaBanEntity.MucTieuPhanGian = MucTieuPhanGian;
				_DiaBanEntity.IdHuyen = IdHuyen;
				_DiaBanEntity.IdXa = IdXa;
				_DiaBanEntity.IdThon = IdThon;
				_DiaBanEntity.Duong = Duong;
				_DiaBanEntity.SoNha = SoNha;
				_DiaBanEntity.IdOkhuVuc = IdOkhuVuc;
				_DiaBanEntity.IdToDanPho = IdToDanPho;
				_DiaBanEntity.CoQuanChuQuanCapTren = CoQuanChuQuanCapTren;
				_DiaBanEntity.DienThoai = DienThoai;
				_DiaBanEntity.NguoiDungDauMucTieu = NguoiDungDauMucTieu;
				_DiaBanEntity.DtddnguoiDungDauMucTieu = DtddnguoiDungDauMucTieu;
				_DiaBanEntity.DtbanNguoiDungDauMucTieu = DtbanNguoiDungDauMucTieu;
				_DiaBanEntity.NguoiDungDauBaoVe = NguoiDungDauBaoVe;
				_DiaBanEntity.DtddnguoiDungDauBaoVe = DtddnguoiDungDauBaoVe;
				_DiaBanEntity.DtbanNguoiDungDauBaoVe = DtbanNguoiDungDauBaoVe;
				_DiaBanEntity.Antt = Antt;
				_DiaBanEntity.CongTacTrienKhai = CongTacTrienKhai;
				_DiaBanEntity.GhiChu = GhiChu;
				_DiaBanEntity.TongSoNhanSu = TongSoNhanSu;
				_DiaBanEntity.DanhSachNhanSu = DanhSachNhanSu;
				_DiaBanEntity.IdNguoiTao = IdNguoiTao;
				_DiaBanEntity.NgayTao = NgayTao;
				_DiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DiaBanEntity.NgayCapNhat = NgayCapNhat;
				_DiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DiaBanEntity, true);
			}
			return _DiaBanEntity;
		}

		public bool Update(DiaBanEntity _DiaBanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DiaBanFields.Id == _DiaBanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DiaBanEntity _DiaBanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string TenDiaBan, string MaRutGon, string SoHoSo, string DiaBanBaoVe, string MucTieuPhanGian, Guid IdHuyen, Guid IdXa, Guid IdThon, string Duong, string SoNha, Guid IdOkhuVuc, Guid IdToDanPho, string CoQuanChuQuanCapTren, string DienThoai, string NguoiDungDauMucTieu, string DtddnguoiDungDauMucTieu, string DtbanNguoiDungDauMucTieu, string NguoiDungDauBaoVe, string DtddnguoiDungDauBaoVe, string DtbanNguoiDungDauBaoVe, string Antt, string CongTacTrienKhai, string GhiChu, string TongSoNhanSu, string DanhSachNhanSu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DiaBanEntity _DiaBanEntity = new DiaBanEntity(Id);
				if (adapter.FetchEntity(_DiaBanEntity))
				{
				
					_DiaBanEntity.TenDiaBan = TenDiaBan;
					_DiaBanEntity.MaRutGon = MaRutGon;
					_DiaBanEntity.SoHoSo = SoHoSo;
					_DiaBanEntity.DiaBanBaoVe = DiaBanBaoVe;
					_DiaBanEntity.MucTieuPhanGian = MucTieuPhanGian;
					_DiaBanEntity.IdHuyen = IdHuyen;
					_DiaBanEntity.IdXa = IdXa;
					_DiaBanEntity.IdThon = IdThon;
					_DiaBanEntity.Duong = Duong;
					_DiaBanEntity.SoNha = SoNha;
					_DiaBanEntity.IdOkhuVuc = IdOkhuVuc;
					_DiaBanEntity.IdToDanPho = IdToDanPho;
					_DiaBanEntity.CoQuanChuQuanCapTren = CoQuanChuQuanCapTren;
					_DiaBanEntity.DienThoai = DienThoai;
					_DiaBanEntity.NguoiDungDauMucTieu = NguoiDungDauMucTieu;
					_DiaBanEntity.DtddnguoiDungDauMucTieu = DtddnguoiDungDauMucTieu;
					_DiaBanEntity.DtbanNguoiDungDauMucTieu = DtbanNguoiDungDauMucTieu;
					_DiaBanEntity.NguoiDungDauBaoVe = NguoiDungDauBaoVe;
					_DiaBanEntity.DtddnguoiDungDauBaoVe = DtddnguoiDungDauBaoVe;
					_DiaBanEntity.DtbanNguoiDungDauBaoVe = DtbanNguoiDungDauBaoVe;
					_DiaBanEntity.Antt = Antt;
					_DiaBanEntity.CongTacTrienKhai = CongTacTrienKhai;
					_DiaBanEntity.GhiChu = GhiChu;
					_DiaBanEntity.TongSoNhanSu = TongSoNhanSu;
					_DiaBanEntity.DanhSachNhanSu = DanhSachNhanSu;
					_DiaBanEntity.IdNguoiTao = IdNguoiTao;
					_DiaBanEntity.NgayTao = NgayTao;
					_DiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_DiaBanEntity.NgayCapNhat = NgayCapNhat;
					_DiaBanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_DiaBanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DiaBanEntity _DiaBanEntity = new DiaBanEntity(Id);
				if (adapter.FetchEntity(_DiaBanEntity))
				{
					adapter.DeleteEntity(_DiaBanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DiaBanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTenDiaBan(string TenDiaBan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TenDiaBan == TenDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoHoSo(string SoHoSo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDiaBanBaoVe(string DiaBanBaoVe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DiaBanBaoVe == DiaBanBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMucTieuPhanGian(string MucTieuPhanGian)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MucTieuPhanGian == MucTieuPhanGian);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHuyen(Guid IdHuyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXa(Guid IdXa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdThon(Guid IdThon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDuong(string Duong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNha(string SoNha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdToDanPho(Guid IdToDanPho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCoQuanChuQuanCapTren(string CoQuanChuQuanCapTren)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDienThoai(string DienThoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DienThoai == DienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNguoiDungDauMucTieu(string NguoiDungDauMucTieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauMucTieu == NguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDtddnguoiDungDauMucTieu(string DtddnguoiDungDauMucTieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDtbanNguoiDungDauMucTieu(string DtbanNguoiDungDauMucTieu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNguoiDungDauBaoVe(string NguoiDungDauBaoVe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauBaoVe == NguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDtddnguoiDungDauBaoVe(string DtddnguoiDungDauBaoVe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDtbanNguoiDungDauBaoVe(string DtbanNguoiDungDauBaoVe)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAntt(string Antt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Antt == Antt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCongTacTrienKhai(string CongTacTrienKhai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CongTacTrienKhai == CongTacTrienKhai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongSoNhanSu(string TongSoNhanSu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TongSoNhanSu == TongSoNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDanhSachNhanSu(string DanhSachNhanSu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DanhSachNhanSu == DanhSachNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DiaBanEntity", filter);
			}
			return toReturn;
		}
		

		
		public DiaBanEntity SelectOne(Guid Id)
		{
			DiaBanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DiaBanEntity _DiaBanEntity = new DiaBanEntity(Id);
				if (adapter.FetchEntity(_DiaBanEntity))
				{
					toReturn = _DiaBanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectAllLST()
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, null, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByTenDiaBanLST(string TenDiaBan)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TenDiaBan == TenDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByTenDiaBanLST_Paged(string TenDiaBan, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TenDiaBan == TenDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTenDiaBanRDT(string TenDiaBan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TenDiaBan == TenDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTenDiaBanRDT_Paged(string TenDiaBan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TenDiaBan == TenDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectBySoHoSoLST(string SoHoSo)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectBySoHoSoLST_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT(string SoHoSo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoHoSoRDT_Paged(string SoHoSo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoHoSo == SoHoSo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDiaBanBaoVeLST(string DiaBanBaoVe)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DiaBanBaoVe == DiaBanBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDiaBanBaoVeLST_Paged(string DiaBanBaoVe, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DiaBanBaoVe == DiaBanBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDiaBanBaoVeRDT(string DiaBanBaoVe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DiaBanBaoVe == DiaBanBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDiaBanBaoVeRDT_Paged(string DiaBanBaoVe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DiaBanBaoVe == DiaBanBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByMucTieuPhanGianLST(string MucTieuPhanGian)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MucTieuPhanGian == MucTieuPhanGian);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByMucTieuPhanGianLST_Paged(string MucTieuPhanGian, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MucTieuPhanGian == MucTieuPhanGian);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMucTieuPhanGianRDT(string MucTieuPhanGian)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MucTieuPhanGian == MucTieuPhanGian);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMucTieuPhanGianRDT_Paged(string MucTieuPhanGian, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.MucTieuPhanGian == MucTieuPhanGian);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdHuyenLST(Guid IdHuyen)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdHuyenLST_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT(Guid IdHuyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdXaLST(Guid IdXa)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdXaLST_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT(Guid IdXa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdThonLST(Guid IdThon)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdThonLST_Paged(Guid IdThon, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdThonRDT(Guid IdThon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdThonRDT_Paged(Guid IdThon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDuongLST(string Duong)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDuongLST_Paged(string Duong, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT(string Duong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT_Paged(string Duong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectBySoNhaLST(string SoNha)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectBySoNhaLST_Paged(string SoNha, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT(string SoNha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT_Paged(string SoNha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdOkhuVucLST(Guid IdOkhuVuc)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdOkhuVucLST_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT(Guid IdOkhuVuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdToDanPhoLST(Guid IdToDanPho)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdToDanPhoLST_Paged(Guid IdToDanPho, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdToDanPhoRDT(Guid IdToDanPho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdToDanPhoRDT_Paged(Guid IdToDanPho, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByCoQuanChuQuanCapTrenLST(string CoQuanChuQuanCapTren)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByCoQuanChuQuanCapTrenLST_Paged(string CoQuanChuQuanCapTren, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCoQuanChuQuanCapTrenRDT(string CoQuanChuQuanCapTren)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCoQuanChuQuanCapTrenRDT_Paged(string CoQuanChuQuanCapTren, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CoQuanChuQuanCapTren == CoQuanChuQuanCapTren);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDienThoaiLST(string DienThoai)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DienThoai == DienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDienThoaiLST_Paged(string DienThoai, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DienThoai == DienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDienThoaiRDT(string DienThoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DienThoai == DienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDienThoaiRDT_Paged(string DienThoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DienThoai == DienThoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNguoiDungDauMucTieuLST(string NguoiDungDauMucTieu)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauMucTieu == NguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNguoiDungDauMucTieuLST_Paged(string NguoiDungDauMucTieu, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauMucTieu == NguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNguoiDungDauMucTieuRDT(string NguoiDungDauMucTieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauMucTieu == NguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNguoiDungDauMucTieuRDT_Paged(string NguoiDungDauMucTieu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauMucTieu == NguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtddnguoiDungDauMucTieuLST(string DtddnguoiDungDauMucTieu)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtddnguoiDungDauMucTieuLST_Paged(string DtddnguoiDungDauMucTieu, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDtddnguoiDungDauMucTieuRDT(string DtddnguoiDungDauMucTieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDtddnguoiDungDauMucTieuRDT_Paged(string DtddnguoiDungDauMucTieu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauMucTieu == DtddnguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtbanNguoiDungDauMucTieuLST(string DtbanNguoiDungDauMucTieu)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtbanNguoiDungDauMucTieuLST_Paged(string DtbanNguoiDungDauMucTieu, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDtbanNguoiDungDauMucTieuRDT(string DtbanNguoiDungDauMucTieu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDtbanNguoiDungDauMucTieuRDT_Paged(string DtbanNguoiDungDauMucTieu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauMucTieu == DtbanNguoiDungDauMucTieu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNguoiDungDauBaoVeLST(string NguoiDungDauBaoVe)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauBaoVe == NguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNguoiDungDauBaoVeLST_Paged(string NguoiDungDauBaoVe, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauBaoVe == NguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNguoiDungDauBaoVeRDT(string NguoiDungDauBaoVe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauBaoVe == NguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNguoiDungDauBaoVeRDT_Paged(string NguoiDungDauBaoVe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NguoiDungDauBaoVe == NguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtddnguoiDungDauBaoVeLST(string DtddnguoiDungDauBaoVe)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtddnguoiDungDauBaoVeLST_Paged(string DtddnguoiDungDauBaoVe, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDtddnguoiDungDauBaoVeRDT(string DtddnguoiDungDauBaoVe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDtddnguoiDungDauBaoVeRDT_Paged(string DtddnguoiDungDauBaoVe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtddnguoiDungDauBaoVe == DtddnguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtbanNguoiDungDauBaoVeLST(string DtbanNguoiDungDauBaoVe)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDtbanNguoiDungDauBaoVeLST_Paged(string DtbanNguoiDungDauBaoVe, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDtbanNguoiDungDauBaoVeRDT(string DtbanNguoiDungDauBaoVe)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDtbanNguoiDungDauBaoVeRDT_Paged(string DtbanNguoiDungDauBaoVe, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DtbanNguoiDungDauBaoVe == DtbanNguoiDungDauBaoVe);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByAnttLST(string Antt)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Antt == Antt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByAnttLST_Paged(string Antt, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Antt == Antt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAnttRDT(string Antt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Antt == Antt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAnttRDT_Paged(string Antt, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.Antt == Antt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByCongTacTrienKhaiLST(string CongTacTrienKhai)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CongTacTrienKhai == CongTacTrienKhai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByCongTacTrienKhaiLST_Paged(string CongTacTrienKhai, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CongTacTrienKhai == CongTacTrienKhai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCongTacTrienKhaiRDT(string CongTacTrienKhai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CongTacTrienKhai == CongTacTrienKhai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCongTacTrienKhaiRDT_Paged(string CongTacTrienKhai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.CongTacTrienKhai == CongTacTrienKhai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByTongSoNhanSuLST(string TongSoNhanSu)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TongSoNhanSu == TongSoNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByTongSoNhanSuLST_Paged(string TongSoNhanSu, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TongSoNhanSu == TongSoNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoNhanSuRDT(string TongSoNhanSu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TongSoNhanSu == TongSoNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongSoNhanSuRDT_Paged(string TongSoNhanSu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TongSoNhanSu == TongSoNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDanhSachNhanSuLST(string DanhSachNhanSu)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DanhSachNhanSu == DanhSachNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByDanhSachNhanSuLST_Paged(string DanhSachNhanSu, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DanhSachNhanSu == DanhSachNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDanhSachNhanSuRDT(string DanhSachNhanSu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DanhSachNhanSu == DanhSachNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDanhSachNhanSuRDT_Paged(string DanhSachNhanSu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.DanhSachNhanSu == DanhSachNhanSu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null);
			}
			return _DiaBanCollection;
		}
		
		// Return EntityCollection<DiaBanEntity>
		public EntityCollection<DiaBanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<DiaBanEntity> _DiaBanCollection = new EntityCollection<DiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DiaBanCollection = new EntityCollection(new DiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
